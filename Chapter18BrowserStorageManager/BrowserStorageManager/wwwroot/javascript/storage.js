export function setItem(storageType, key, value) {
    const storage = storageType === 'session'
        ? sessionStorage : localStorage;
    storage.setItem(key, value);
}
export function getItem(storageType, key) {
    const storage = storageType === 'session'
        ? sessionStorage : localStorage;
    return storage.getItem(key);
}
export function removeItem(storageType, key) {
    const storage = storageType === 'session'
        ? sessionStorage : localStorage;
    storage.removeItem(key);
}
export function clear(storageType) {
    const storage = storageType === 'session'
        ? sessionStorage : localStorage;
    storage.clear();
}
