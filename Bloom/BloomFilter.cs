using System;
using System.Collections.Generic;

namespace Bloom
{
	public class BloomFilter<T>
	{
		private bool[] Filter { get; set; }
		private int HashCount { get; }
		private int HashShiftStep { get; }

		public BloomFilter(int size, int hashCount)
		{
			if (size < 1)
				throw new Exception("Bloom filter size must be > 0");
			if (hashCount < 1 || hashCount > 8)
				throw new Exception("Hash count should be between 1 and 8.");

			Filter = new bool[size];
			HashCount = hashCount;
			HashShiftStep = 32 / hashCount;
		}

		public bool this[T value] => Contains(value);

		public void Add(T value)
		{
			uint hash = (uint)value.GetHashCode();
			for (int i = 0; i < HashCount; i++)
				Filter[(hash >> (i * HashShiftStep)) % Filter.Length] = true;
		}

		public void AddRange(IEnumerable<T> values)
		{
			foreach (T value in values)
				Add(value);
		}

		public void Clear()
		{
			for (int i = 0; i < Filter.Length; i++)
				Filter[i] = false;
		}

		public bool Contains(T value)
		{
			uint hash = (uint)value.GetHashCode();
			for (int i = 0; i < HashCount; i++)
			{
				if (!Filter[(hash >> (i * HashShiftStep)) % Filter.Length])
					return false;
			}
			return true;
		}
	}
}
