﻿using System.Text.Json;

public class DataMahasiswa_1302204056
{
    public class DataMahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string courses { get; set; }
    }

    public void ReadJSON()
    {
        string file = "jurnal6_1_nim.json" ;

        string dataStr = File.ReadAllText(file) ;

        DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(dataStr) ;

        Console.WriteLine($"Nama depan {dataMahasiswa.firstName} nama belakang {dataMahasiswa.lastName} gender {dataMahasiswa.gender} beralamat di {dataMahasiswa.address} mengambil matkul {dataMahasiswa.courses}") ;
    }
}