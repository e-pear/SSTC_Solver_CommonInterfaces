using System;
using System.Collections.Generic;
using System.Text;

namespace SSTC_Solver_CommonInterfaces
{
    public interface I_LinearEquationSystemSolvingAlgorithm
    {
        /// <summary>
        /// Solves linear equations system: AX = B.
        /// </summary>
        /// <param name="A">Coefficient Array.</param>
        /// <param name="B">Vector of corresponding free parameters.</param>
        /// <param name="X">Vector of solutions.</param>
        /// <returns>True if calculations succeeded.</returns>
        bool Solve_LinearEquationSystem(double[,] A, double[] B, ref double[] X);
        /// <summary>
        /// Algorithm name property.
        /// </summary>
        string LabelName { get; }
        /// <summary>
        /// Algorithm short description property.
        /// </summary>
        string Description { get; }
    }
}
