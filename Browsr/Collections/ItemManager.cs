using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics.Contracts;
using System.Collections;

namespace Browsr
{
    /// <summary>
    /// ItemManager
    /// This class is intended to be used to handle the management and storage of collections of information used within Browsr, namely a user's tabs, history and bookmarks
    /// </summary>
    public class ItemManager<T> {

        private Dictionary<int, T> items;

        public Dictionary<int, T> Items {

            get {

                return items;

            }

            set {

                items = value;

            }

        }

        public ItemManager() {

            items = new Dictionary<int, T>();

        }

        public int FindKeyByTitle(String title) {

            return Items.FirstOrDefault(item => (item.Value as Item).Title == title).Key;

        }

        public int GetUniqueKey() {

            return items.Keys.Max() + 1;

        }

        /// <summary>
        /// Add an item to the collecton
        /// </summary>
        /// <param name="key"></param>
        public void AddItem(T item) {

            if(items.Count == 0)
                items.Add(0, item);
            else
                items.Add(GetUniqueKey(), item);

        }

        /// <summary>
        /// Remove an item from the collecton
        /// </summary>
        /// <param name="key"></param>
        public void RemoveItem(int key) {

            items.Remove(key);

        }

        /// <summary>
        /// Serialize items and store in JSON file
        /// </summary>
        /// <param name="path"></param>
        public void SaveToFile(String path) {

            Contract.Requires(!String.IsNullOrEmpty(path));

            String json = JsonConvert.SerializeObject(items, Formatting.Indented);

            Contract.Requires(!String.IsNullOrEmpty(json), "Warning: the serialized JSON output of the object was null or empty.");

            File.WriteAllText(path, json);

        }

        /// <summary>
        /// Deserialize and import items from a JSON file
        /// </summary>
        /// <param name="path"></param>
        public void OpenFromFile(String path) {

            Contract.Requires(!String.IsNullOrEmpty(path));

            String json = String.Join("", File.ReadLines(path));

            Dictionary<int, T> deserialized = JsonConvert.DeserializeObject<Dictionary<int, T>>(json);

            Contract.Ensures((deserialized != null && deserialized.Count > 0), "Warning: opening the file '"+path+"' did not produce any results.");

            Items = deserialized;

        }

    }
}
