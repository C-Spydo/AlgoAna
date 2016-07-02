using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAna
{
    class bucketsort
    {
	public int[] sort(int[] sequence, int maxValue) {
	 // Bucket Sort
		int[] Bucket = new int[maxValue + 1];
		int[] sorted_sequence = new int[sequence.Length];
		for (int i = 0; i < sequence.Length; i++){
			Bucket[sequence[i]]++;  //creates buckets to hold various numbers of a given range
		}
			int outPos = 0;
			for (int i = 0; i < Bucket.Length; i++){  //sorts the times in each individual bucket
				for (int j = 0; j < Bucket[i]; j++){
					sorted_sequence[outPos++] = i;
				}
			}
		return sorted_sequence;	//returns the sorted items into the original array
		}

	    public  int maxValue(int[] sequence){  //this method is to obtain the maximum value in the array
											// it does this by using an algorithm similar to bubblesort
		int maxValue = 0;
		for (int i = 0; i < sequence.Length; i++){
			if (sequence[i] > maxValue)
				maxValue = sequence[i];
		
		}
		return maxValue;

    }//end of max value method
	
}

	/*static void printSequence(int[] sorted_sequence){
		for (int i = 0; i < sorted_sequence.length; i++){
			System.out.print(sorted_sequence[i] + " ");
		}
	}*/

    }

