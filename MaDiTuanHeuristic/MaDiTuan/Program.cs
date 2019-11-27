using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaDiTuan
{
    class ToaDo
    {
        public int dong;
        public int cot;
        public ToaDo(int d, int c)  //Constructor
        {
            dong = d; // d là dòng
            cot = c;  // c là cột
        }
    }
    class maDiTuan   //khai báo method
    {

        public int[,] banCo;
        public int N;
        // public int x, y;  // y là dòng, x là cột
        public ToaDo t;
        public maDiTuan(int n,int yy, int xx)  //Constructor
        {
            banCo = new int[n,n];
            N = n;
            t = new ToaDo(yy, xx);
            banCo[t.dong, t.cot] = 1;
            //banCo[y, x] = 1;
        }


        public void inBanCo()  //method
        {
            for(int y = 0; y < N; y++)
            {
                for(int x = 0; x < N; x++)
                {
                    Console.Write(banCo[y,x] + "\t");
                }
                Console.WriteLine();
            }
        }


        public List<ToaDo> sinhNuocDi(ToaDo k)
        {
            int[] dy = {-2,-1,1,2,2,1,-1,-2 };
            int[] dx = {1,2,2,1,-1,-2,-2,-1 };
            List<ToaDo> dsNuocdi = new List<ToaDo>();
            for(int i = 0;i<8;i++)
            {
                int ty = k.dong + dy[i];
                int tx = k.cot + dx[i];
                if (tx >= 0 && ty >= 0 && tx < N && ty < N && banCo[ty, tx] == 0)
                {
                    dsNuocdi.Add(new ToaDo(ty, tx));
                }
            }
            return dsNuocdi;
        }
        public void diTuan()
        {
            int nd = 2;
            int size = N * N;
            while (nd <= size)
            {
                List<ToaDo> ncMoi = sinhNuocDi(t);
                if(ncMoi.Count==0 && nd<=size)
                {
                    Console.WriteLine("Khong thay loi giai");
                    break;
                }
                int min = 10;
                ToaDo t2 = new ToaDo(0,0);
                for(int i = 0;i<ncMoi.Count;i++)
                {
                    List<ToaDo> tmpdsNuocdi = sinhNuocDi(ncMoi[i]);
                    if(tmpdsNuocdi.Count<min)
                    {
                        min = tmpdsNuocdi.Count;
                        t2 = ncMoi[i];
                    }
                }
                t = t2;
                banCo[t.dong, t.cot] = nd;
                nd++;
            }
            if(nd>=size)
            {
                inBanCo();            
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Ma di tuan------");
            Console.Write("Nhap kich co ban co: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do dong bat dau: ");
            int y = int.Parse(Console.ReadLine())-1;  // vi tri trong mang nen -1
            Console.Write("Nhap toa do cot bat dau: ");
            int x = int.Parse(Console.ReadLine())-1; // vi tri trong mang nen -1
            maDiTuan mdt = new maDiTuan(n,y,x);
            mdt.diTuan();
            Console.ReadLine();
        }
    }
}
