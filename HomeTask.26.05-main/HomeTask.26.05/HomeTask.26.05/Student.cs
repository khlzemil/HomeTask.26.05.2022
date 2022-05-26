using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask._26._05
{
    public class Student
    {
        private int[] _newGrades;
        public int[] Grades
        {
            get
            {
                return _newGrades;
            }
            set
            {
                int[] evenArr = new int[0];
                int i = 0;
                for(int j = 0; j < value.Length; j++)
                {
                    if (value[j] % 2 == 0)
                    {
                        Array.Resize(ref evenArr, evenArr.Length+1);
                        evenArr[i] = value[j];
                        i++;
                    }

                }
                if(evenArr.Length > 0)
                {
                    _newGrades = evenArr;
                }
                else
                {
                    _newGrades = new int[] { 0,0,0,0,0,0 };
                }


            }
        }

    }
}
        

    

