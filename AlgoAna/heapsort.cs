using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAna
{
    class heapsort
    {
	//declaring private fields
    private static int[] a;
    private static int n;
    private static int left;
    private static int right;
    private static int largest;

    
    public static void buildheap(int []a){  //this method builds a heap out of all the elements to be sorted
        n=a.Length-1;
        for(int i=n/2;i>=0;i--){
            maxheap(a,i);
        }
    }//end buildheap method
    
    public static void maxheap(int[] a, int i){      // the maxheap method ensures that the elements above any element k
    // in the heap is greater than k, and the element below k is smaller than k.
        left=2*i;
        right=2*i+1;
        if(left <= n && a[left] > a[i]){
            largest=left;
        }
        else{
            largest=i;
        }
        
        if(right <= n && a[right] > a[largest]){
            largest=right;
        }
        if(largest!=i){
            exchange(i,largest);
            maxheap(a, largest);
        }
    }//end maxheap method
    
    public static void exchange(int i, int j){  // exchange method is for swapping elements to 
    //ensure that each element is well placed.
        int t=a[i];
        a[i]=a[j];
        a[j]=t; 
        }
    
    public  void sortt(int []a0){ //this is the sorting method itself, it relies on the exchange, maxheap and buildheap methods.
        a=a0;
        buildheap(a);
        
        for(int i=n;i>0;i--){
            exchange(0, i);
            n=n-1;
            maxheap(a, 0);
        }
    }// sort method
   
}// end heapsort class


    }

