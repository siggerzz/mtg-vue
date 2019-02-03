import Repository from '../repositories/repository';

const resource = "/SearchFilter/GetFilters";
export default {
    getFilters() {
        return Repository.get(`${resource}`);
    }
}