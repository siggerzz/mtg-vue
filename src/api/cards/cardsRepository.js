import Repository from '../repositories/repository';

const cardsResource = "/Cards/GetCards";
const cardResource = "/Cards/GetCard";

export default {
    getCards(cardName, colours, set, format, type) {
        return Repository.get(`${cardsResource}?name=${cardName}&colorIdentity=${colours}&set=${set}&format=${format}&type=${type}`);
    },
    getCard(multiverseid) {
        return Repository.get(`${cardResource}/${multiverseid}`);
    }
}