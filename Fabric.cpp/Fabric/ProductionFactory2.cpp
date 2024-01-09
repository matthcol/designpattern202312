#include "ProductionFactory2.h"
#include "Movie2.h"

std::shared_ptr<IProductionFactory> ProductionFactory2::m_instance = nullptr;

std::shared_ptr<IMovie> ProductionFactory2::createMovie(const std::string& title, uint16_t year) const
{
    return std::shared_ptr<IMovie>(new Movie2(title, year));
}

std::shared_ptr<IProductionFactory> ProductionFactory2::instance()
{
    if (ProductionFactory2::m_instance == nullptr) {
        ProductionFactory2::m_instance = std::shared_ptr<IProductionFactory>(new ProductionFactory2());
    }
    return ProductionFactory2::m_instance;
}