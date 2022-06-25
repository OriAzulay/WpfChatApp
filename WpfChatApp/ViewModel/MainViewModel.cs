using WpfChatApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfChatApp.Core;

namespace WpfChatApp.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }

        public ObservableCollection<ContactModel> Contacts { get; set; }

        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;
        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });
                Message = " ";
            });

            Messages.Add(new MessageModel
            {
                Username = "Alice",
                UsernameColor = "#409aff",
                ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });


            Messages.Add(new MessageModel
            {
                Username = "Alice",
                UsernameColor = "#409aff",
                ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                Message = "Welcome here!",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = false
            });

            Messages.Add(new MessageModel
            {
                Username = "Johny",
                UsernameColor = "#409aff",
                ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                Message = "This is my last message",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

            Contacts.Add(new ContactModel
            {
                Username = "Bob",
                ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                Messages = Messages

            });
            Contacts.Add(new ContactModel
            {
                Username = "Alice",
                ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                Messages = Messages

            });
            Contacts.Add(new ContactModel
            {
                Username = "Johny",
                ImageSource = "https://www.business2community.com/social-media-articles/importance-profile-picture-career-01899604",
                Messages = Messages

            });

        }


    }
}
