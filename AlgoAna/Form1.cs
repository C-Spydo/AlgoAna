
/* Comparison and testing of sorting algorithms using C# Programming Language
 *Algorithms Tested:  Heap Sort, Bucket Sort and Shell Sort
 *Programmer: Popoola Ajibola
 *				Matric Number: 170699
 *				MSc Computer Science, University of Ibadan.
 *Lecturer-In-Charge: Dr Akinola S.A
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoAna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }
        double initialTime, finalTime,timeTaken;
        private void button1_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(cmbSize.Text);

            int[]A=new int [n];
            Random random = new Random();
		    for (int i=0;i<n;i++){
                  
                  A[i] = random.Next(1, 50);
                    
                }
                
                //generating random numbers to fill the array
		

            switch(cmbAlgo.SelectedIndex){
                case 0:  //code for calling Shell sort algorithm
		  		    MessageBox.Show("You chose Shell Sort Algorithm"+"\nYou are Sorting "+n+" Numbers"+"\n","Alert");
		  		    shellsort shell=new shellsort();
                    initialTime=DateTime.Now.Millisecond;
                    txtbefore.Text=printarray(A);
		  		    shell.shellsortt(A);
                    txtafter.Text=printarray(A);
		  		    finalTime = DateTime.Now.Millisecond;
		  		    timeTaken=finalTime-initialTime;
                    txtTime.Text=timeTaken+" milliSeconds";
		  		    break;

                case 1:  //code for calling Heap sort algorithm
                    MessageBox.Show("You chose Heap Sort Algorithm" + "\nYou are Sorting " + n + " Numbers" + "\n", "Alert");
                    heapsort heap = new heapsort();
                    initialTime = DateTime.Now.Millisecond;
                    txtbefore.Text = printarray(A);
                    heap.sortt(A);
                    txtafter.Text = printarray(A);
                    finalTime = DateTime.Now.Millisecond;
                    timeTaken = finalTime - initialTime;
                    txtTime.Text = timeTaken + " milliSeconds";
                    break;

                case 2:  //code for calling Bucket sort algorithm
                    MessageBox.Show("You chose Bucket Sort Algorithm" + "\nYou are Sorting " + n + " Numbers" + "\n", "Alert");
                    bucketsort bucket = new bucketsort();
                    int max = bucket.maxValue(A);
                    txtbefore.Text = printarray(A);
                    initialTime = DateTime.Now.Millisecond;
                    bucket.sort(A, max);
                    txtafter.Text = printarray(A);
                    finalTime = DateTime.Now.Millisecond;
                    timeTaken = finalTime - initialTime;
                    txtTime.Text = timeTaken + " milliSeconds";
                    break;
		  	    
		    }	
          }

        public string printarray(int[] A) {
            string outp = "";
            for (int i = 0; i < A.Length; i++) {
                outp += A[i] + "\t";
            }
            return outp;
        }

        }

}

	