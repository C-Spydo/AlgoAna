using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAna
{
    class shellsort
    {

	    public  void shellsortt(int[] a) {
		    int increment = a.Length / 2;  //initial gap sequence
		    while (increment > 0) {// to ensure that the gap sequence ends at 1
			    for (int i = increment; i < a.Length; i++) {
				    int j = i;
				    // code to sort the sub arrays
				    int temp = a[i];
				    while (j >= increment && a[j - increment] > temp) {
					    a[j] = a[j - increment];
					    j = j - increment;
				    }
				    a[j] = temp;
				
			    }
			    if (increment == 2) {
				    increment = 1;
			    } else {
				    increment *= Convert.ToInt32((5.0 / 11));  //formula for calculating subsequent gap sequences from the initial gap
			    }
		    }
	    }//end shellsort method
    }// end shellsort class

}

