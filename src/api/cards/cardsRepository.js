import Repository from '../repositories/repository';

const resource = "/Cards/GetCards";
export default {
    getCards(cardName, colours, set, format, type) {
        return Repository.get(`${resource}?name=${cardName}&colorIdentity=${colours}&set=${set}&format=${format}&type=${type}`);
    }
}