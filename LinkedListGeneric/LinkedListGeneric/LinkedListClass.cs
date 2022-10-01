using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGeneric
{
    //Created by Nimmala
    //22222222222222222
    class LinkedListClass<T> : IEnumerable<T>
    {
        //Properties
        public LLNodeMarker<T> First { get; set; }
        public LLNodeMarker<T> Last { get; set; }

        //Method
        public LLNodeMarker<T> AddLast(T node)
        {
            //This method accepts an incoming argument of type LLNodeMarker<T>(could be a value of any generic data type)

            //call the LinkNode class and create a new linked list node of the incoming value
            var newNode = new LLNodeMarker<T>(node);

            //Now set the previous and next node properties of the node.
            //If this is the first one, then there is no previous or next node.
            if (this.First == null)
            {
                First = newNode;// sets incoming node value as the first node.
                Last = newNode;// This is the only node, so first and last node is the same.
            }
            else
            {
                //if this is the not the first node, ther is already one,
                //make the current node as the previous one,and make the incoming node as the current one.
                LLNodeMarker<T> previous = Last;
                Last.NextNode = newNode;//incoming node is attached as the next node to the current last node.
                Last = newNode;//setting the newly received node as the last node.
                Last.PreviousNode = previous;//Assigning the node that arrived earlier as the last node because:
                                             //the previous node to the new node(last node)just got added.

            }// End if/else
            //Now the new node has the earlier nodes as previous node and the nwe node is the last node now.
            //Very first arriving node is the first node.
            //just added one more node to the chain of nodes
            return newNode;


        }//end method AddLast
        public IEnumerator<T> GetEnumerator()
        {
            //This method loops through a given list and returns one node at a time
            LLNodeMarker<T> current = First;
            while (current != null)
            {
                yield return current.ValueProperty;
                //Yield return statement returns one node in the loop at a time,without exiting the method
                //because of the return statement.
                //Control remains with the method even after the return statement occuring.
                current = current.NextNode;
            }// end of While
        }//end GetEnumerator method
        IEnumerator IEnumerable.GetEnumerator()
        {
            //This is the implementation of IEnumerable.GetEnumerator() because the class derives from InterfaceIEnumerable<T>
            //which implements this method.
            //IEnumerable interface exposes the Enumerator, which supports a simple iteration over a non-generic collection.
            return GetEnumerator();
        }//End GetEnumerator()
    }//End LinkedListClass
}
