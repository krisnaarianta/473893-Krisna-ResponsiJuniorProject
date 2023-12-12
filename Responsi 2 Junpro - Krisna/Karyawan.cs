using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_2_Junpro___Krisna
{
    public class Karyawan
    {
            private int _id_karyawan;
            private string _nama;
            private string _id_dep;

            public int id_karyawan
            {
                get { return _id_karyawan; }
                set { _id_karyawan = value; }
            }

            public string nama
            {
                get { return _nama; }
                set { _nama = value; }
            }

            public string id_dep
            {
                get { return _id_dep; }
                set { _id_dep = value; }
            }

        
    }

    public class Magang : Karyawan
    {
        public void KaryawanMagang()
        {
            Console.WriteLine("Karyawan Magang");
            Console.WriteLine(id_dep + "-M");
        }

    }
}

