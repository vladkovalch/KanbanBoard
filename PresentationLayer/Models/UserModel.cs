﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace PresentationLayer.Models
{
    public class UserModel : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public ObservableCollection<BoardModel> Boards { get; set; }
        public UserProfileModel Profile { get; set; }
        public string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                IsValidEmail(value);
                OnPropertyChanged(nameof(Email));
            }
        }
        private bool _loaderVisible;
       
        private bool IsValidEmail(string value)
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = reg.Match(value);
            if (match.Success)
            {
                _email = value;
                return true;
            }
            else
            {
                return false;
            }
        }
        private string _password;
        public string Sha256Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = ComputeSha256Hash(value);
                OnPropertyChanged(nameof(Sha256Password));
            }
        }
        public UserModel()
        {
            Boards = new ObservableCollection<BoardModel>();
        }

        static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        #region Wrong Methods
        //public static bool IsValidEmail(string email)
        //{
        //    if (string.IsNullOrWhiteSpace(email))
        //        return false;

        //    try
        //    {
        //        // Normalize the domain
        //        email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
        //                              RegexOptions.None, TimeSpan.FromMilliseconds(200));

        //        // Examines the domain part of the email and normalizes it.
        //        string DomainMapper(Match match)
        //        {
        //            // Use IdnMapping class to convert Unicode domain names.
        //            var idn = new IdnMapping();

        //            // Pull out and process domain name (throws ArgumentException on invalid)
        //            var domainName = idn.GetAscii(match.Groups[2].Value);

        //            return match.Groups[1].Value + domainName;
        //        }
        //    }
        //    catch (RegexMatchTimeoutException e)
        //    {
        //        return false;
        //    }
        //    catch (ArgumentException e)
        //    {
        //        return false;
        //    }

        //    try
        //    {
        //        return Regex.IsMatch(email,
        //            @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
        //            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
        //            RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        //    }
        //    catch (RegexMatchTimeoutException)
        //    {
        //        return false;
        //    }
        //}
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
        //public Action<UserModel> AddTagToCardAct;

        //COMMANDS
        //private RelayCommand _inviteUserCmd;
        //public RelayCommand InviteUserCmd
        //{
        //    get
        //    {
        //        return _inviteUserCmd ?? (_inviteUserCmd = new RelayCommand(() =>
        //        {
        //            AddTagToCardAct.Invoke(this);
        //        }));
        //    }
        //}
}
