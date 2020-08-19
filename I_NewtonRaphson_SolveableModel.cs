using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTC_Solver_CommonInterfaces
{
    //
    public interface I_NewtonRaphson_SolveableModel
    {
        int VectorBaseSize { get; }
        double[] Get_Vector_F(double[] initialSolutionsVector_X);
        double[,] Get_Jacobian_J(double[] initialSsolutionsVector_X);
    }
}
