using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_Asgmt.Assignment_2
{
    public class UI
    {
        public static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine(
                    "1 - Calculate angle \n" +
                    "2 - Tree depth \n" +
                    "0 - Exit");

                Console.WriteLine("Choice:");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ClockAngles.ClockUI();

                        break;

                    case "2":
                        Tree tree = new Tree(new Branch());

                        tree.Branch.branches.Add(new Branch());
                        tree.Branch.branches.Add(new Branch());

                        tree.Branch.branches[0].branches.Add(new Branch());
                        tree.Branch.branches[0].branches.Add(new Branch());
                        tree.Branch.branches[1].branches.Add(new Branch());
                        tree.Branch.branches[1].branches.Add(new Branch());

                        tree.Branch.branches[0].branches[0].branches.Add(new Branch());
                        tree.Branch.branches[0].branches[1].branches.Add(new Branch());
                        tree.Branch.branches[1].branches[0].branches.Add(new Branch());
                        tree.Branch.branches[1].branches[1].branches.Add(new Branch());

                        tree.Branch.branches[0].branches[0].branches[0].branches.Add(new Branch());
                        tree.Branch.branches[0].branches[1].branches[0].branches.Add(new Branch());
                        tree.Branch.branches[1].branches[0].branches[0].branches.Add(new Branch());
                        tree.Branch.branches[1].branches[1].branches[0].branches.Add(new Branch());

                        int depth = tree.CalculateDepth(tree.Branch);
                        Console.WriteLine("Depth is: {0}", depth);

                        break;

                    case "0":
                        Environment.Exit(0);

                        break;
                }
            }
        }
    }
}
