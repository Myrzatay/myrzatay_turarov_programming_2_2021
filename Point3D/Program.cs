using System;

namespace Point3D
{
     public class Point3d{
        private double _x;
        private double _y;
        private double _z;
        public double X => _x;
        public double Y => _y;
        public double Z => _z;
        public Point3d(double x, double y, double z){
            _x = x;
            _y = y;
            _z = z;
        }
        public void MoveAlongY(double y){
            _y+=y;
        }

        public void CastToXZ(){
            _y=0;
        }
        public bool IsOnXZPlane(){
            if(_y == 0){
                return true;
            }
            return false;
        }
        public bool IsOnPlane(){
            if((_x == 0 && _y!=0 && _z!=0)||(_z != 0 && _y==0 && _x!=0)||(_x != 0 && _y!=0 && _z==0)){
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
