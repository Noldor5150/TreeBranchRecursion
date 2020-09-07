using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeBranchRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Branch tree = new Branch
            {
                Branches = new List<Branch>
                {
                    new Branch
                    {
                        Branches = new List<Branch>()
                    },
                    new Branch
                    {
                        Branches = new List<Branch>
                        {
                            new Branch
                            {
                                Branches = new List<Branch>()
                            },
                            new Branch
                            {
                                Branches = new List<Branch>()
                            },
                            new Branch
                            {
                                Branches = new List<Branch>
                                {
                                    new Branch 
                                    {
                                     Branches  = new List<Branch>() 
                                    },
                                    new Branch
                                    {
                                     Branches  = new List<Branch>
                                     {
                                         new Branch
                                         {
                                              Branches  = new List<Branch>()
                                         },
                                         new Branch
                                         {
                                              Branches  = new List<Branch>
                                              {
                                                  new Branch
                                                  {
                                                      Branches  = new List<Branch>()
                                                  }
                                              }
                                         },
                                         new Branch
                                         {
                                              Branches  = new List<Branch>()
                                         }

                                     }
                                    },
                                    new Branch
                                    {
                                     Branches  = new List<Branch>()
                                    }
                                }
                            }
                        }
                    }
                }
            };
            Console.WriteLine(CalculateTreeHeight(tree));
        }

        static int CalculateTreeHeight(Branch tree, int deepestPoint = 0, int currentDepth = 0)
        {
            currentDepth++;
            if (deepestPoint < currentDepth)
            {
                deepestPoint = currentDepth;
            }
            foreach (var branch in tree.Branches)
            {
                deepestPoint = CalculateTreeHeight(branch, deepestPoint, currentDepth);
            }
            return deepestPoint;
        }
    }

}
