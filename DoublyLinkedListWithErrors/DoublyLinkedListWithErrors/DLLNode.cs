using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
    // Namespace declaration
    // All code within this namespace belongs to the DoublyLinkedListWithErrors namespace
    public class DLLNode
    {
        public int num;               // field of the node to hold a number
        public DLLNode next;          // pointer to the next node in the list
        public DLLNode previous;      // pointer to the previous node in the list

        // Constructor for DLLNode class
        // Initializes the num field with the provided value and sets next and previous references to null
        public DLLNode(int num)
        {
            this.num = num;
            next = null;
            previous = null;
        }

        // Method to check if a number is prime
        // Returns true if the number is prime, false otherwise
        public Boolean isPrime(int n)
        {
            Boolean b = true;

            if (n < 2)
            {
                return (false);
            }
            else
            {
                // Loop from 2 to the square root of n
                // Check if there is any divisor for n
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if ((n % i) == 0)
                    {
                        b = false;
                        break;
                    }
                }
            }

            return (b);
        }
    }
}
