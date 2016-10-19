using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Browsr
{
    public class Browsr {

        private ItemManager<Tab> _tabs;
        private ItemManager<Item> _bookmarks;
        private ItemManager<Item> _history;
        private Dictionary<String, Object> _settings;

        public ItemManager<Tab> Tabs {

            get {
                return _tabs;
            }

            set {
                _tabs = value;
            }

        }
        public ItemManager<Item> Bookmarks {

            get {
                return _bookmarks;
            }

            set {
                _bookmarks = value;
            }

        }
        public ItemManager<Item> History {

            get {
                return _history;
            }

            set {
                _history = value;
            }

        }
        public Dictionary<String, Object> Settings {

            get {
                return _settings;
            }

            set {
                _settings = value;
            }

        }
        public Item Homepage {

            get {
                return Settings["Homepage"] as Item;
            }

            set {
                Settings["Homepage"] = value;
            }

        }

        public Browsr() {

            // Initialise data structures for use
            Tabs = new ItemManager<Tab>();
            History = new ItemManager<Item>();
            Bookmarks = new ItemManager<Item>();
            Settings = new Dictionary<String, Object>();

            SetDefaultSettings();

            // Get user data
            Load();

        }

        private void LoadStruct(Object obj, String pathShort, List<String> warnings) {

            String path = "../../Data/" + pathShort;

            // Check if the file exists
            if(!File.Exists(path)) {

                // If it doesn't, create it
                File.Create(path);

            } else {

                // Check the file length, show a warning to the user if it's empty

                if(new FileInfo(path).Length != 0) {

                    // Check the object type
                    // And appropriate convert
                    if(IsDictionary(obj)) {

                        String json = String.Join("", File.ReadLines(path));

                        Settings = JsonConvert.DeserializeObject<Dictionary<String, Object>>(json, new JsonSerializerSettings {
                            TypeNameHandling = TypeNameHandling.Auto
                        });

                    } else
                        (obj as ItemManager<Item>).OpenFromFile(path);


                } else
                    warnings.Add("The " + pathShort + " data file was empty.");


            }

        }

        private void Load() {

            List<String> warnings = new List<String>();

            LoadStruct(Settings, "settings.json", warnings);
            LoadStruct(History, "history.json", warnings);
            LoadStruct(Bookmarks, "bookmarks.json", warnings);

            if(warnings.Count > 0)
                MessageBox.Show(String.Join("\n", warnings.ToArray()),
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

        }

        private void SetDefaultSettings() {

            Settings = new Dictionary<String, Object> { // Default browser settings

                {
                    "Homepage", new Item("Google", "http://google.co.uk")
                },
                {
                    "ShowHomepage", true
                }

            };

        }

        private bool IsDictionary(Object o) {

            Type t = o.GetType();
            return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Dictionary<,>);

        }

        private void SaveStruct(Object obj, String pathShort) {

            String path = "../../Data/" + pathShort;

            if(IsDictionary(obj)) {

                var jsonSerializerSettings = new JsonSerializerSettings() {
                    TypeNameHandling = TypeNameHandling.All
                };
                String json = JsonConvert.SerializeObject(obj, jsonSerializerSettings);

                File.WriteAllText(path, json);

            } else {

                // Since we only have two types, dictionary and ItemManger, and we know it's not a dictionary, we can safely cast the structure as an item manager
                (obj as ItemManager<Item>).SaveToFile(path);

            }

        }

        public void Save() {

            SaveStruct(Settings, "settings.json");
            SaveStruct(History, "history.json");
            SaveStruct(Bookmarks, "bookmarks.json");

        }

    }

}
