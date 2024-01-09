#pragma once
#include "IProductionFactory.h"
#include <memory>
class ProductionFactory2: public IProductionFactory
{
private:
	static std::shared_ptr<IProductionFactory> m_instance;
	ProductionFactory2() = default;
public:
	virtual std::shared_ptr<IMovie> createMovie(const std::string& title, uint16_t year) const override;
	static std::shared_ptr<IProductionFactory> instance();
};

