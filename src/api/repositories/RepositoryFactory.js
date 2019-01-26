import CardsRepository from '../cards/cardsRepository';
import SetsRepository from '../sets/setsRepository';

const repositories = {
    cards: CardsRepository,
    sets: SetsRepository
}

export const RepositoryFactory = {
    get: name => repositories[name]
};