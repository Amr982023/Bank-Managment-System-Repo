using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Common;
using Mapster;

namespace MyBankSystemManagmentProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // RegisterClientMappings();         
            
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUserForm());  
            clsErrorEvents.on_Error += ShowError;
        }

        private static void ShowError(string Msg)
        {
            MessageBox.Show($"Error : {Msg}");
        }
        //public static void RegisterMappings()
        //{
        //    TypeAdapterConfig<ClientDTO, clsClient>
        //        .NewConfig()
        //        .Map(dest => dest.ID, src => src.ID)
        //        .Map(dest => dest.FirstName, src => src.FirstName)
        //        .Map(dest => dest.LastName, src => src.LastName)
        //        .Map(dest => dest.Email, src => src.Email)
        //        .Map(dest => dest.Phone, src => src.Phone)
        //        .Map(dest => dest.PhotoPath, src => src.PhotoPath)
        //        .Map(dest => dest.AccountNumber, src => src.AccountNumber)
        //        .Map(dest => dest.Password, src => src.Password)
        //        .Map(dest => dest.Balance, src => src.Balance)
        //        .AfterMapping((src, dest) => dest.Mode = clsClient.enMode.Update);

        //    TypeAdapterConfig<clsUser, UserDTO>
        //        .NewConfig()
        //        .Map(dest => dest.ID, src => src.ID)
        //        .Map(dest => dest.FirstName, src => src.FirstName)
        //        .Map(dest => dest.LastName, src => src.LastName)
        //        .Map(dest => dest.Email, src => src.Email)
        //        .Map(dest => dest.Phone, src => src.Phone)
        //        .Map(dest => dest.PhotoPath, src => src.PhotoPath)
        //        .Map(dest => dest.UserName, src => src.UserName)
        //        .Map(dest => dest.Password, src => src.Password)
        //        .Map(dest => dest._Permission, src => src._Permission);
        //}
        //public static void RegisterClientMappings()
        //{
        //    TypeAdapterConfig<ClientDTO, clsClient>
        //        .NewConfig()
        //        .Map(dest => dest.ID, src => src.ID)
        //        .Map(dest => dest.FirstName, src => src.FirstName)
        //        .Map(dest => dest.LastName, src => src.LastName)
        //        .Map(dest => dest.Email, src => src.Email)
        //        .Map(dest => dest.Phone, src => src.Phone)
        //        .Map(dest => dest.PhotoPath, src => src.PhotoPath)
        //        .Map(dest => dest.AccountNumber, src => src.AccountNumber)
        //        .Map(dest => dest.Password, src => src.Password)
        //        .Map(dest => dest.Balance, src => src.Balance)
        //        .AfterMapping((src, dest) => dest.Mode = clsClient.enMode.Update);
        //}
    }
}
