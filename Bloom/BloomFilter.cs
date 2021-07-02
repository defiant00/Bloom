using System;
using System.Collections;
using System.Collections.Generic;

namespace Bloom
{
	// This is an implementation of a bloom filter using generics, taking advantage of the
	// fact that all objects in C# have a GetHashCode method.
	//
	// The primary advantages of this method are that it works with any C# type, and is
	// quite performant since the initial hash is only performed once per insert or check.
	//
	// The primary disadvantage is that GetHashCode returns an int, so all hash values are
	// based off of that single value. It is therefore possible that for a specific type
	// (eg, strings), using multiple more specialized hashing functions would produce
	// a more even and random distribution of values, reducing false positives.
	public class BloomFilter<T>
	{
		// A BitArray is used here instead of a simple bool[] for memory reasons.
		// C# uses a byte per item in a bool[], so BitArray uses ~1/8 of the memory.
		private BitArray Filter { get; set; }
		// The number of hash values to use.
		private int HashCount { get; }
		// The number of bits to shift per hash step.
		private int HashShiftStep { get; }

		/// <summary>
		/// Create a new bloom filter with the specified size in bits, that will
		/// utilize the specified number of hash values.
		/// </summary>
		/// <param name="size">The size of the filter in bits.</param>
		/// <param name="hashCount">Number of hash values to use, valid values are 1-8.</param>
		public BloomFilter(int size, int hashCount)
		{
			if (size < 1)
				throw new Exception("Bloom filter size must be > 0.");
			if (hashCount < 1 || hashCount > 8)
				throw new Exception("Hash count must be between 1 and 8.");

			Filter = new BitArray(size);
			HashCount = hashCount;

			// The 32 here is from GetHashCode returning a 32-bit integer. That is also
			// the reasoning for limiting HashCount to 8, since there are only so many
			// useful distinct values you can get out of a single int.
			HashShiftStep = 32 / hashCount;
		}

		/// <summary>
		/// Check whether a value might be in the filter.
		/// </summary>
		/// <param name="value">The value to check for.</param>
		/// <returns>True if it might be in the filter, or false if it absolutely is not.</returns>
		public bool this[T value] => Contains(value);

		/// <summary>
		/// Add a value to the filter.
		/// </summary>
		/// <param name="value">The value to add.</param>
		public void Add(T value)
		{
			uint hash = (uint)value.GetHashCode();
			for (int i = 0; i < HashCount; i++)
				Filter[GetIndex(hash, i)] = true;
		}

		/// <summary>
		/// Add a range of values to the filter.
		/// </summary>
		/// <param name="values">The values to add.</param>
		public void AddRange(IEnumerable<T> values)
		{
			foreach (T value in values)
				Add(value);
		}

		/// <summary>
		/// Clear the filter.
		/// </summary>
		public void Clear() => Filter.SetAll(false);

		/// <summary>
		/// Check whether a value might be in the filter.
		/// </summary>
		/// <param name="value">The value to check for.</param>
		/// <returns>True if it might be in the filter, or false if it absolutely is not.</returns>
		public bool Contains(T value)
		{
			uint hash = (uint)value.GetHashCode();
			for (int i = 0; i < HashCount; i++)
			{
				if (!Filter[GetIndex(hash, i)])
					return false;
			}
			return true;
		}

		// Helper method to get the array index to check, given the object's initial hash
		// and which hash step we are on.
		//
		// Basic idea is to take the initial hash cast to uint to avoid negative numbers,
		// bitwise rotate it by (step * HashShiftStep) bits, so we're effectively reading the
		// bits like a ring buffer with different starting indices each step, and then modding
		// that by the filter size to map it to the filter array.
		//
		// So if the hash count is 1 we just use the initial hash.
		// For 2 we use the initial hash and then the hash rotated 16 bits, effectively reading
		// starting in the middle.
		// For 3 we use the initial hash, one rotated 10 bits, and one rotated 20, etc.
		//
		//
		// I initially considered just bit shifting to the right instead of rotation, but that
		// would likely produce a disproportionate number of small values, which would cause
		// the filter to perform worse.
		private int GetIndex(uint hash, int step)
		{
			int offset = step * HashShiftStep;
			uint rotatedHash = (hash >> offset) | (hash << (32 - offset));
			return (int)(rotatedHash % Filter.Count);
		}
	}
}
