#include "IMovie.h"

std::ostream& operator<<(std::ostream& out, const IMovie& movie)
{
	return out << movie.toString();
}
