﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplimat_labs.Models
{
    class Vector3
    {
        public float x, y, z;

        public Vector3()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public Vector3(double _x, double _y, double _z)
        {
            x = (float)_x;
            y = (float)_y;
            z = (float)_z;
        }

        public static Vector3 operator + (Vector3 left, Vector3 right)
        {
            return new Vector3(left.x + right.x, 
                left.y + right.y,
                left.z + right.z);
        }

        public static Vector3 operator - (Vector3 left, Vector3 right)
        {
            return new Vector3(left.x - right.x,
                left.y - right.y,
                left.z - right.z);
        }

    }
}
