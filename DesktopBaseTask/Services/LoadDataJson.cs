using DesktopBaseTask.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace DesktopBaseTask.Services
{
    public class LoadDataJson
    {
        /// <summary>
        /// Расположение файла с людьми
        /// </summary>
        private string pathPersons;
        /// <summary>
        /// Расположение файла с контактами
        /// </summary>
        private string pathContacts;

        public LoadDataJson()
        {
            pathPersons = @"big_data_persons.json";
            pathContacts = @"big_data_contracts.json";
        }

        /// <summary>
        /// Загружает людей из json-файла
        /// </summary>
        /// <returns>Список людей</returns>
        public ObservableCollection<Person> GetPersons()
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Person>>(File.ReadAllText(pathPersons));
        }

        /// <summary>
        /// Загружает контакты из json-файла
        /// </summary>
        /// <returns>Список контактов</returns>
        public ObservableCollection<Contact> GetContacts()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatString = "dd'.'MM'.'yyyy' 'H':'mm':'ss";
            return JsonConvert.DeserializeObject<ObservableCollection<Contact>>(File.ReadAllText(pathContacts), settings);
        }
    }
}
