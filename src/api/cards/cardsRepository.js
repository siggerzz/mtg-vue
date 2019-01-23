import Repository from '../repositories/repository';

const resource = "/Cards/GetCards";
export default {
    getCards(cardName) {
        return Repository.get(`${resource}?name=${cardName}`);
    }
}