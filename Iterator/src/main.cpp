#include <string>
#include <vector>
#include <iostream>
#include <list>
#include <random>
#include <cmath>
#include <algorithm>

// displayIterable with limit (x firsts, x lasts): Input/Forward iterator
template<class InputIt>
void displayIterable(InputIt first, InputIt last, size_t limit=10){

}

void iterateCities(){
    std::vector<std::string> cities {
        "Toulouse",
        "Pau",
        "Bayonne",
        "Carcassonne",
        "Limoges",
        "Montpellier",
        "Paris"
    };
    for (const auto& city: cities){  // implicit use of const_iterator
        std::cout << "\t*" << city << std::endl;
    }
    std::cout << "city: " << cities[2] << std::endl; // random access
    std::vector<std::string>::const_iterator it = cities.cbegin();
    std::vector<std::string>::const_iterator end = cities.cend();
    while (it != end) {
        const std::string& city = *it;
        std::cout << "\t-" << city << std::endl;
        ++it;
    }
    auto it2 = cities.begin() + 2;
    std::cout << "city read: " << *it2 << std::endl;
    *it2 = "Biarritz";
    std::cout << "city read: " << *it2 << std::endl;

    std::list<std::string> parcours(cities.crbegin()+1, cities.crend()-1);
    std::cout << "Parcours: ";
    for (const auto& city: parcours) {
        std::cout << city << " ";
    }
    std::cout << std::endl;
    //auto it3 = parcours.begin() + 2;  // compilation error (not a random iterator)
    auto it3 = std::next(parcours.begin(), 2);  // compilation error (not a random iterator)
    std::cout << "city read: " << *it3 << std::endl;
}

void iterateNumbers(){
    std::random_device rd{};
    std::mt19937 gen{rd()};
 
    // values near the mean are the most likely
    // standard deviation affects the dispersion of generated values from the mean
    std::normal_distribution<double> d{12.0, 3.0};
 
    // draw a sample from the normal distribution and round it to an integer
    // auto random_int = [&d, &gen]{ return std::round(d(gen)); };

    std::vector<double> numbers(1000000);
    std::generate(numbers.begin(), numbers.end(), [&d, &gen]{ return d(gen); });
    for (int i=0; i<10; ++i) {
        std::cout << numbers[i] << std::endl;
    }
}


int main(){
    iterateCities();
    iterateNumbers();
}