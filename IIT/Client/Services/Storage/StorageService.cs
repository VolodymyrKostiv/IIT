﻿using Blazored.LocalStorage;

namespace IIT.Client.Services.Storage
{
    public class StorageService
    {
        private ILocalStorageService _storage;

        public StorageService(ILocalStorageService storage)
        {
            _storage = storage;
        }

        protected async Task AddItem<T>(string itemName, T item)
        {
            bool itemExists = await _storage.ContainKeyAsync(itemName);
            if (itemExists)
            {
                await _storage.RemoveItemAsync(itemName);
            }

            await _storage.SetItemAsync(itemName, item);
        }

        protected async Task<bool> ItemExists(string itemName)
        {
            bool itemExists = await _storage.ContainKeyAsync(itemName);

            return itemExists;
        }

        protected async Task<T> GetItem<T>(string itemName)
        {
            bool itemExists = await _storage.ContainKeyAsync(itemName);
            if (itemExists)
            {
                var item = await _storage.GetItemAsync<T>(itemName);
                return item;
            }

            return default;
        }

        protected async Task RemoveItem(string itemName)
        {
            bool itemExists = await _storage.ContainKeyAsync(itemName);
            if (itemExists)
            {
                await _storage.RemoveItemAsync(itemName);
            }
        }

        protected async Task UpdateItem<T>(string itemName, T item)
        {
            await AddItem(itemName, item);
        }
    }
}
