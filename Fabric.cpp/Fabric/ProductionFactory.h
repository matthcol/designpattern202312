#pragma once
#include "IProductionFactory.h"

class ProductionFactory: public IProductionFactory
{
private:
	static std::shared_ptr<IProductionFactory> m_instance;
	ProductionFactory() = default;
public:
	virtual std::shared_ptr<IMovie> createMovie(const std::string& title, uint16_t year) const override;
	static std::shared_ptr<IProductionFactory> instance();
};

