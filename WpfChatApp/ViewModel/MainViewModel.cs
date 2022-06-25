using WpfChatApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfChatApp.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }

        public ObservableCollection<ContactModel> Contacts { get; set; }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            {
                Username = "Bob",
                UsernameColor = "#409aff",
                ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for(int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Alice",
                    UsernameColor = "#409aff",
                    ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }
            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Johny",
                    UsernameColor = "#409aff",
                    ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                    FirstMessage = false
                });
            }
            Messages.Add(new MessageModel
            {
                Username = "Johny",
                UsernameColor = "#409aff",
                ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Bob {i}",
                    ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                    Messages = Messages

                });
            }
        }


    }
}
