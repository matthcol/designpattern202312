#include "Application.h"
//#include "ProductionFactory.h"
#include "ProductionFactory2.h"


std::shared_ptr<IProductionFactory> Application::productionFactoryInstance() const
{
    // return std::shared_ptr<IProductionFactory>(ProductionFactory::instance());
    return std::shared_ptr<IProductionFactory>(ProductionFactory2::instance());
}
