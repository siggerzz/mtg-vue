import CardsRepository from '../cards/cardsRepository';
import SearchFilterRepository from '../sets/searchFilterRepository';

const repositories = {
    cards: CardsRepository,
    searchFilters: SearchFilterRepository
}

export const RepositoryFactory = {
    get: name => repositories[name]
};