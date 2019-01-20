import Repository from '../repositories/repository';

const resource = "/Cards/GetCards";
export default {
    getCards(searchTerm) {
        return Repository.get(`${resource}?${searchTerm}`);
    }
}