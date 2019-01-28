import Repository from '../repositories/repository';

const resource = "/Cards/GetCards";
export default {
    getCards(cardName, colours) {
        return Repository.get(`${resource}?name=${cardName}&colorIdentity=${colours}`);
    }
}