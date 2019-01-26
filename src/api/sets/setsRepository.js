import Repository from '../repositories/repository';

const resource = "/Sets/GetSets";
export default {
    getSets() {
        return Repository.get(`${resource}`);
    }
}