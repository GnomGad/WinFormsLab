using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLab
{
    interface IStart
    {
        void CreateAuthorizationBinaryFile(string Path);
        bool ExistAuthorizationBinaryFile(string Path);
        StructAutorization[] ReadLoginPasswordAuthorizationBinaryFile(string Path);
        void WriteLoginPasswordAuthorizationBinaryFile(string Path, StructAutorization Autorization);
        bool CheckLogin(string Login1, string Login2);
        bool CheckPassword(string Password1, string Password2);
        bool CheckNullInString(string text);

    }
}
