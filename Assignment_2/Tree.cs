using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_Asgmt.Assignment_2
{
    public class Tree
    {
        public Branch Branch { get; set; }

        public Tree(Branch branch)
        {
            Branch = branch;
        }

        public int CalculateDepth(Branch branch)
        {
            foreach (var item in branch.branches)
            {
                int depth = CalculateDepth(item);
                return depth + 1;
            }

            return 1;
        }
    }
}
