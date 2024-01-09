#include "AbstractApplication.h"

void AbstractApplication::watchMovies() {
    std::shared_ptr<IProductionFactory> productionFactory = productionFactoryInstance();
    std::cout << "Fabric (watch) @: " << productionFactory << std::endl;
    for (uint16_t i = 1; i <= 10; i++) {
        std::shared_ptr<IMovie> movie = productionFactory->createMovie("X-Men" + std::to_string(i), 1990 + i);
        std::cout << "Watch: " << *movie << std::endl;
    }
}

void AbstractApplication::run()
{
    std::shared_ptr<IProductionFactory> productionFactory = productionFactoryInstance();
    std::cout << "Fabric (main) @: " << productionFactory << std::endl;

    std::shared_ptr<IMovie> movie = productionFactory->createMovie("Oppenheimer", 2023);
    std::cout << "Main movie: " << *movie << std::endl;
    watchMovies();
}
