using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace MyContacts
{
    interface IMyContacts
    {
        DataTable SelectAll();
        DataTable SelectRow(int ContactID);
        DataTable Search(string word);
        bool insert(string Name,string Family,int Age,string Email,string Mobile);
        bool Update(int ContactID, string Name, string Family, int Age, string Email, string Mobile);
        bool delete(int ContactID);
        bool Insert(string text1, string text2, int value, string text3, string text4);
        bool Update(int ContactID, string Name, string Family, int Age, string Email, string Mobile, object connection);
    }
}
