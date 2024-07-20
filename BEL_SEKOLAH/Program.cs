using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Component;
using Database;
using System.Threading;

namespace BEL_SEKOLAH
{
    class Program
    {
        public static AccessDatabaseHelper DB = new AccessDatabaseHelper("./intan.accdb");
                                                                                                                             
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            //Tulisan Judul = new Tulisan();
            //Judul.Text = "APLIKASI BEL SEKOLAH";
            //Judul.X = 49;                                                
            //Judul.Y = 2;
            //Judul.Tampil();

            Kotak Kepala = new Kotak();
            Kepala.X = 0;
            Kepala.Y = 0;
            Kepala.Width = 119;
            Kepala.Height = 5;
            Kepala.SetForeColor(ConsoleColor.Magenta);
            Kepala.Tampil();

            Kotak bawahkiri = new Kotak();
            bawahkiri.X = 0;
            bawahkiri.Y = 25;
            bawahkiri.Width = 29 ;
            bawahkiri.Height = 3;
            bawahkiri.SetForeColor(ConsoleColor.Magenta);
            bawahkiri.Tampil();

            Kotak bawahkanan = new Kotak();
            bawahkanan.X = 30;
            bawahkanan.Y = 25;
            bawahkanan.Width = 89;
            bawahkanan.Height = 3;
            bawahkanan.SetForeColor(ConsoleColor.Magenta);
            bawahkanan.Tampil();

            Kotak kiri = new Kotak();
            kiri.SetXY(0, 6);
            kiri.SetWidthAndHeight(29, 18);
            kiri.SetForeColor(ConsoleColor.Cyan);
            kiri.Tampil();

            Kotak kanan = new Kotak();
            kanan.SetXY(30, 6);
            kanan.SetWidthAndHeight(89, 18);
            kanan.SetForeColor(ConsoleColor.Cyan);
            kanan.Tampil();

            Tulisan NamaAplikasi = new Tulisan();
            NamaAplikasi.Text = "APLIKASI BEL SEKOLAH";
            NamaAplikasi.SetXY(0, 1);
            NamaAplikasi.Length = 119;
            NamaAplikasi.SetForeColor(ConsoleColor.Blue);
            NamaAplikasi.TampilTengah();
            
            Tulisan Sekolah = new Tulisan();
            Sekolah.Text = "WEARNES EDUCATION CENTER MADIUN";
            Sekolah.SetXY(0, 2).SetLength(119);
            Sekolah.SetForeColor(ConsoleColor.Cyan);
            Sekolah.TampilTengah();

            Tulisan Alamat = new Tulisan();
            Alamat.Text = "Jl. Thamrin 35A Kota Madiun";
            Alamat.SetXY(0, 3);
            Alamat.SetForeColor(ConsoleColor.DarkCyan);
            Alamat.SetLength(119);
            Alamat.TampilTengah();

            //Tulisan Atas Kiri
            new Tulisan().SetXY(1, 1).SetText("   ▄██▄ ▄██▄     ▄██▄ ▄██▄ ").SetLength(119).SetForeColor(ConsoleColor.DarkRed).Tampil(); Thread.Sleep(100);
            new Tulisan().SetXY(1, 2).SetText("  ▀█████████▀   ▀█████████▀").SetLength(119).SetForeColor(ConsoleColor.DarkRed).Tampil(); Thread.Sleep(100);
            new Tulisan().SetXY(1, 3).SetText("    ▀█████▀       ▀█████▀  ").SetLength(119).SetForeColor(ConsoleColor.DarkRed).Tampil(); Thread.Sleep(100);
            new Tulisan().SetXY(1, 4).SetText("      ▀█▀           ▀█▀    ").SetLength(119).SetForeColor(ConsoleColor.DarkRed).Tampil(); Thread.Sleep(100);

            //Tulisan Atas Kanan
            new Tulisan().SetXY(90, 1).SetText("   ▄██▄ ▄██▄     ▄██▄ ▄██▄ ").SetLength(119).SetForeColor(ConsoleColor.DarkRed).Tampil(); Thread.Sleep(100);
            new Tulisan().SetXY(90, 2).SetText("  ▀█████████▀   ▀█████████▀").SetLength(119).SetForeColor(ConsoleColor.DarkRed).Tampil(); Thread.Sleep(100);
            new Tulisan().SetXY(90, 3).SetText("    ▀█████▀       ▀█████▀  ").SetLength(119).SetForeColor(ConsoleColor.DarkRed).Tampil(); Thread.Sleep(100);
            new Tulisan().SetXY(90, 4).SetText("      ▀█▀           ▀█▀    ").SetLength(119).SetForeColor(ConsoleColor.DarkRed).Tampil(); Thread.Sleep(100);

            //Tulisan Bawah 
            new Tulisan().SetText("INTAN NUR AINI").SetXY(0, 26).SetLength(30).SetForeColor(ConsoleColor.DarkCyan).TampilTengah();
            new Tulisan().SetXY(0, 27).SetText("INFORMATIKA II").SetLength(30).SetForeColor(ConsoleColor.DarkCyan).TampilTengah();
            
           

            for (int z = 1; z <= 2; z++)
            {
                for (int i = 1; i <= 43; i++)
                {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(30 + (i * 2), 25 + z);
                Console.Write("▀▄");
                Thread.Sleep(50);
                }
            }


            Menu menu = new Menu("► JALANKAN", "► LIHAT DATA", "► TAMBAH DATA", "► EDIT DATA", "► HAPUS DATA", "► KELUAR");
            menu.SetXY(7, 10);
            menu.ForeColor = ConsoleColor.DarkCyan;
            menu.SetSelectedForeColor(ConsoleColor.DarkGreen);
            menu.Tampil();

            bool IsProgramJalan = true;

            while (IsProgramJalan)
            {
                ConsoleKeyInfo Tombol = Console.ReadKey(true);

                if (Tombol.Key == ConsoleKey.DownArrow)
                {
                    //Tombol Panah Ke Bawah
                    menu.Next();
                    menu.Tampil();
                }
                else if (Tombol.Key == ConsoleKey.UpArrow)
                {
                    //Tombol Panah Ke Atas
                    menu.Prev();
                    menu.Tampil();
                }
                else if (Tombol.Key == ConsoleKey.Enter)
                {
                    //Enter
                    int MenuTerpilih = menu.SelectedIndex;

                    if (MenuTerpilih == 0)
                    {
                        //Menu Jalankan
                        Jalankan();
                    }
                    else if (MenuTerpilih == 1)
                    {
                        //Menu Lihat Data
                        LihatData();
                    }
                    else if (MenuTerpilih == 2)
                    {
                        TambahData();
                    }
                    else if (MenuTerpilih == 3)
                    {
                        EditData();
                    }
                    else if (MenuTerpilih == 4)
                    {
                        HapusData();
                    }
                    else if (MenuTerpilih == 5)
                    {
                        IsProgramJalan = false;
                    }
                }

            }
                    
        }
         
        static void Jalankan()
        {
            new Clear(32, 7, 87, 16).Tampil();

            //Tulisan Judul = new Tulisan();
            //Judul.SetXY(31, 7).SetText(".: JALANKAN PROGRAM :.").SetLength(88);
            //Judul.TampilTengah();
            
            new Tulisan().SetXY(31, 8).SetText(" ░░█ ▄▀█ █░░ ▄▀█ █▄░█ █▄▀ ▄▀█ █▄░█   █▀█ █▀█ █▀█ █▀▀ █▀█ ▄▀█ █▀▄▀█ ").SetLength(88).SetForeColor(ConsoleColor.DarkRed).TampilTengah();
            new Tulisan().SetXY(31, 9).SetText(" █▄█ █▀█ █▄▄ █▀█ █░▀█ █░█ █▀█ █░▀█   █▀▀ █▀▄ █▄█ █▄█ █▀▄ █▀█ █░▀░█ ").SetLength(88).SetForeColor(ConsoleColor.DarkRed).TampilTengah();
           
            Tulisan HariSekarang = new Tulisan().SetXY(62, 11);
            Tulisan JamSekarang = new Tulisan().SetXY(62, 12);

            string QSelect = "SELECT * FROM tb_jadwal WHERE hari=@hari AND jam=@jam;";

            DB.Connect();

            bool Play = true;
            
            while (Play)
            {

                DateTime Sekarang = DateTime.Now;

                HariSekarang.SetText("HARI SEKARANG : " + Sekarang.ToString("dddd"));
                HariSekarang.SetForeColor(ConsoleColor.Cyan).Tampil();

                JamSekarang.SetText("JAM SEKARANG  : " + Sekarang.ToString("HH:mm:ss"));
                JamSekarang.SetForeColor(ConsoleColor.Cyan).Tampil();

                DataTable DT = DB.RunQuery(QSelect,
                    new OleDbParameter("@hari", Sekarang.ToString("dddd")),
                    new OleDbParameter("@jam", Sekarang.ToString("HH:mm")));

                if(DT.Rows.Count > 0)
                {
                    Audio HAAA = new Audio();
                    HAAA.File = "./Suara/" + DT.Rows[0]["sound"];
                    HAAA.Play();

                    new Tulisan().SetXY(31, 14).SetText("BEL TELAH BERBUNYI!!!").SetBackColor(ConsoleColor.Red).SetLength(88).TampilTengah();
                    new Tulisan().SetXY(31, 15).SetText(DT.Rows[0]["ket"].ToString()).SetBackColor(ConsoleColor.Red).SetLength(88).TampilTengah();

                    Play = false;
                }

                Thread.Sleep(1000);
            }
        }

        static void LihatData()
        {
            new Clear(32, 7, 86, 16).Tampil();

            //Tulisan Judul = new Tulisan();
            //Judul.SetXY(31, 7).SetText(".: LIHAT DATA JADWAL :.").SetLength(88);
            //Judul.TampilTengah();
                        
            new Tulisan().SetXY(31, 8).SetText("█░░ █ █░█ ▄▀█ ▀█▀   █▀▄ ▄▀█ ▀█▀ ▄▀█").SetLength(88).SetForeColor(ConsoleColor.DarkMagenta).TampilTengah();
            new Tulisan().SetXY(31, 9).SetText("█▄▄ █ █▀█ █▀█ ░█░   █▄▀ █▀█ ░█░ █▀█").SetLength(88).SetForeColor(ConsoleColor.DarkMagenta).TampilTengah();
            
            DB.Connect();
            DataTable DT = DB.RunQuery("SELECT * FROM tb_jadwal;");
            DB.Disconnect();

            new Tulisan("┌──────┬──────────────┬─────────┬─────────────────────────────────────────────────┐").SetXY(34, 11).SetForeColor(ConsoleColor.Magenta).Tampil();
            new Tulisan("│  NO  │     HARI     │   JAM   │                   KETERANGAN                    │").SetXY(34, 12).SetForeColor(ConsoleColor.Magenta).Tampil();
            new Tulisan("├──────┼──────────────┼─────────┼─────────────────────────────────────────────────┤").SetXY(34, 13).SetForeColor(ConsoleColor.Magenta).Tampil();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string ID = DT.Rows[i]["id"].ToString();
                string Hari = DT.Rows[i]["hari"].ToString();
                string Jam = DT.Rows[i]["jam"].ToString();
                string Keterngan = DT.Rows[i]["ket"].ToString();

                string isi = String.Format("│{0, -6}│{1, -14}│{2, -9}│{3, -49}│", ID, Hari, Jam, Keterngan);
                new Tulisan(isi).SetXY(34, 14 + i).SetForeColor(ConsoleColor.Magenta).Tampil();
            }

            new Tulisan("└──────┴──────────────┴─────────┴─────────────────────────────────────────────────┘").SetXY(34, 14 + DT.Rows.Count).SetForeColor(ConsoleColor.Magenta).Tampil();

        }

        static void TambahData()
        {
            new Clear(32, 7, 87, 16).Tampil();

            //Tulisan Judul = new Tulisan();
            //Judul.SetXY(31, 7).SetText(".: TAMBAH DATA :.").SetLength(88);
            //Judul.TampilTengah();

            new Tulisan().SetXY(31, 8).SetText(" ▀█▀ ▄▀█ █▀▄▀█ █▄▄ ▄▀█ █░█   █▀▄ ▄▀█ ▀█▀ ▄▀█").SetLength(88).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan().SetXY(31, 9).SetText(" ░█░ █▀█ █░▀░█ █▄█ █▀█ █▀█   █▄▀ █▀█ ░█░ █▀█").SetLength(88).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();

            Inputan HariInput = new Inputan();
            HariInput.Text = "Masukan Hari          :";
            HariInput.SetXY(45, 11).SetForeColor(ConsoleColor.Cyan);

            Inputan JamInput = new Inputan();
            JamInput.Text = "Masukan Jam           :";
            JamInput.SetXY(45, 12).SetForeColor(ConsoleColor.Cyan);

            Inputan KetInput = new Inputan();
            KetInput.Text = "Masukan Keterangan    :";
            KetInput.SetXY(45, 13).SetForeColor(ConsoleColor.Cyan);

            //Inputan SoundInput = new Inputan();
            //SoundInput.Text = "Masukan Sound         :";
            //SoundInput.SetXY(33, 12);

            Pilihan SoundInput = new Pilihan();
            SoundInput.SetPilihans(
                "5 Menit Akhir Istirahat I.wav",
                "5 Menit Akhir Istirahat II.wav",
                "5 Menit Akhir Kegiatan Keagamaan.wav",
                "5 Menit Awal Kegiatan Keagamaan.wav",
                "5 Menit Awal Upacara.wav",
                "Akhir Pekan 1.wav",
                "Akhir Pekan 2.wav",
                "Akhir Pelajaran A.wav",
                "Akhir Pelajaran B.wav",
                "Awal jam ke 1.wav",
                "Istirahat I.wav",
                "Istirahat II.wav", 
                "Pelajaran ke 1.wav", 
                "Pelajaran ke 2.wav",
                "Pelajaran ke 3.wav", 
                "Pelajaran ke 4.wav",
                "Pelajaran ke 5.wav", 
                "Pelajaran ke 6.wav",
                "Pelajaran ke 7.wav",
                "Pelajaran ke 8.wav",
                "Pelajaran ke 9.wav", 
                "pembuka.wav");

            SoundInput.Text = "Masukkan Audio        :";
            SoundInput.SetXY(45, 14).SetForeColor(ConsoleColor.Cyan);
            
            string Hari = HariInput.Read();
            string Jam = JamInput.Read();
            string Ket = KetInput.Read();
            string Sound = SoundInput.Read();

            DB.Connect();
            DB.RunNonQuery("INSERT INTO tb_jadwal ( hari, jam, ket, sound ) VALUES ( @hari, @jam, @ket, @sound );",
                new OleDbParameter("@hari", Hari),
                new OleDbParameter("@jam", Jam),
                new OleDbParameter("@ket", Ket),
                new OleDbParameter("@sound", Sound)
                );

            DB.Disconnect();

            new Tulisan().SetXY(31, 16).SetText("Data Berhasil Di SIMPAN!!!").SetBackColor(ConsoleColor.Red).SetLength(88).TampilTengah();
        }

        static void EditData()
        {
            new Clear(32, 7, 87, 16).Tampil();

            //Tulisan Judul = new Tulisan();
            //Judul.SetXY(31, 7).SetText(".: EDIT DATA :.").SetLength(88);
            //Judul.TampilTengah();

            new Tulisan().SetXY(31, 8).SetText(" █▀▀ █▀▄ █ ▀█▀   █▀▄ ▄▀█ ▀█▀ ▄▀█").SetLength(88).SetForeColor(ConsoleColor.DarkGreen).TampilTengah();
            new Tulisan().SetXY(31, 9).SetText(" ██▄ █▄▀ █ ░█░   █▄▀ █▀█ ░█░ █▀█").SetLength(88).SetForeColor(ConsoleColor.DarkGreen).TampilTengah();

            Inputan IDInputDirubah = new Inputan();
            IDInputDirubah.Text = "Masukkan ID Jadwal Yang Di Rubah :";
            IDInputDirubah.SetXY(45, 11).SetForeColor(ConsoleColor.Cyan);

            Inputan HariInput = new Inputan();
            HariInput.Text = "Masukan Hari                     :";
            HariInput.SetXY(45, 12).SetForeColor(ConsoleColor.Cyan);

            Inputan JamInput = new Inputan();
            JamInput.Text = "Masukan Jam                      :";
            JamInput.SetXY(45, 13).SetForeColor(ConsoleColor.Cyan);

            Inputan KetInput = new Inputan();
            KetInput.Text = "Masukan Keterangan               :";
            KetInput.SetXY(45, 14).SetForeColor(ConsoleColor.Cyan);

            //Inputan SoundInput = new Inputan();
            //SoundInput.Text = "Masukan Sound         :";
            //SoundInput.SetXY(33, 12);
                        
            Pilihan SoundInput = new Pilihan();
            SoundInput.SetPilihans(
                "5 Menit Akhir Istirahat I.wav",
                "5 Menit Akhir Istirahat II.wav",
                "5 Menit Akhir Kegiatan Keagamaan.wav",
                "5 Menit Awal Kegiatan Keagamaan.wav",
                "5 Menit Awal Upacara.wav",
                "Akhir Pekan 1.wav",
                "Akhir Pekan 2.wav",
                "Akhir Pelajaran A.wav",
                "Akhir Pelajaran B.wav",
                "Awal jam ke 1.wav",
                "Istirahat I.wav",
                "Istirahat II.wav",
                "Pelajaran ke 1.wav",
                "Pelajaran ke 2.wav",
                "Pelajaran ke 3.wav",
                "Pelajaran ke 4.wav",
                "Pelajaran ke 5.wav",
                "Pelajaran ke 6.wav",
                "Pelajaran ke 7.wav",
                "Pelajaran ke 8.wav",
                "Pelajaran ke 9.wav",
                "pembuka.wav");

            SoundInput.Text = "Masukkan Audio                   :";
            SoundInput.SetXY(45, 15).SetForeColor(ConsoleColor.Cyan);
            
            string IDRubah = IDInputDirubah.Read();
            string Hari = HariInput.Read();
            string Jam = JamInput.Read();
            string Ket = KetInput.Read();
            string Sound = SoundInput.Read();

            DB.Connect();
            DB.RunNonQuery("UPDATE tb_jadwal SET hari=@hari, jam=@jam, ket=@ket, sound=@sound WHERE id=@id;",
                new OleDbParameter("@hari", Hari),
                new OleDbParameter("@jam", Jam),
                new OleDbParameter("@ket", Ket),
                new OleDbParameter("@sound", Sound),
                new OleDbParameter("@id", IDRubah)
                );

            DB.Disconnect();

            new Tulisan().SetXY(32, 17).SetText("Data Berhasil Di UPDATE!!!").SetBackColor(ConsoleColor.Red).SetLength(88).TampilTengah();
        }
        
        static void HapusData()
        {
            new Clear(32, 7, 87, 16).Tampil();

            //Tulisan Judul = new Tulisan();
            //Judul.SetXY(31, 7).SetText(".: HAPUS DATA :.").SetLength(88);
            //Judul.TampilTengah();

            new Tulisan().SetXY(31, 8).SetText("█░█ ▄▀█ █▀█ █░█ █▀   █▀▄ ▄▀█ ▀█▀ ▄▀█").SetLength(88).SetForeColor(ConsoleColor.DarkGreen).TampilTengah();
            new Tulisan().SetXY(31, 9).SetText("█▀█ █▀█ █▀▀ █▄█ ▄█   █▄▀ █▀█ ░█░ █▀█").SetLength(88).SetForeColor(ConsoleColor.DarkGreen).TampilTengah();

            Inputan IDInput = new Inputan();
            IDInput.Text = "Masukkan ID Yang Akan Di Hapus :";
            IDInput.SetXY(58, 11).SetForeColor(ConsoleColor.Cyan);
            string ID = IDInput.Read();
                                                                     

            DB.Connect();
            DB.RunNonQuery("DELETE FROM tb_jadwal WHERE id=@id",
                new OleDbParameter("@id", ID));

            new Tulisan().SetXY(31, 13).SetText("Data Berhasil Di HAPUS!!!").SetBackColor(ConsoleColor.Red).SetLength(88).TampilTengah();
        }
                          
    }
}
