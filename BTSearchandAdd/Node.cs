﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTSearchandAdd
{
    class Node
    {

       
        
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public int Data { get; set; }
        public int key;
        public int count;
        
        public Node Parent { get; set; }
        
        public int numberInNode;

            //constructor


            public Node(int numberInNode)
            {

                this.numberInNode = numberInNode;
               LeftNode = null;
                RightNode = null;
            }

            public int NumberInNode
            {
                get
                {
                    return numberInNode;
                }
                set
                {
                    numberInNode = value;
                }
            }

         

        }
    }

