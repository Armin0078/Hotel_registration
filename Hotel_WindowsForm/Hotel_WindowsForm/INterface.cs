using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hotel_WindowsForm
{
    internal interface INterface
    {
        float Cost(int count, int floor, int day , float hour);

        string person(string  name , string family);

        DataTable bank();

        DataTable Search(string parameter);

        bool CheckAdmin(string username , string password);

        bool InsertInformation(string Room , string Name , string Family , string FamilyCounts , string cost , int day , float hour);

        bool EditInformation(string Room, string Name, string Family, string FamilyCounts, string cost, int day, float hour);



    }
}
