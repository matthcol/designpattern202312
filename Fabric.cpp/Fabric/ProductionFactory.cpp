#include "ProductionFactory.h"
#include "Movie.h"

std::shared_ptr<IProductionFactory> ProductionFactory::m_instance = nullptr;

std::shared_ptr<IMovie> ProductionFactory::createMovie(const std::string& title, uint16_t year) const
{
    return std::shared_ptr<IMovie>(new Movie(title, year));
}

std::shared_ptr<IProductionFactory> ProductionFactory::instance()
{
    if (ProductionFactory::m_instance == nullptr) {
        ProductionFactory::m_instance = std::shared_ptr<IProductionFactory>(new ProductionFactory());
    }
    return ProductionFactory::m_instance;
}
