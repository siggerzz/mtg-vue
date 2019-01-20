import CardsRepository from '../cards/cardsRepository';

const repositories = {
    cards: CardsRepository
}

export const RepositoryFactory = {
    get: name => repositories[name]
};