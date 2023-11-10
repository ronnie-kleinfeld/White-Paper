import requests
import config

URL = "https://api.yelp.com/v3/businesses/search"

headers = {
    "accept": "application/json",
    "Authorization": "Bearer " + config.API_KEY,
}

params = {
    "term": "atelier",
    "location": "N7 9GB",
    "sort_by": "best_match",
    "limit": "20",
}

response = requests.get(URL, headers=headers, params=params)

print(response)  # <Response [200]>
print(response.text)  # same as response.json()

businesses = response.json()["businesses"]
for business in businesses:
    print(f"{business["name"]} - {business["rating"]}")

good_businesses = [
    business["name"] for business in businesses if business["rating"] > 4.7
]
print(good_businesses) # ['The Complete Cobbler', 'Adam Grooming Atelier', 'Adam Grooming Atelier', 'Adam Grooming Atelier', 'The Hairy Bastard', 'Atelier EC1']

# {
#     "businesses": [
#         {
#             "id": "DG hWO1sUWydVeR5j5ZZaMw",
#             "alias": "la-grande-boucherie-new-york-2",
#             "name": "La Grande Boucherie",
#             "image_url": "https://s3-media3.fl.yelpcdn.com/bphoto/b9URGcuuhnLq7J-__pHIng/o.jpg",
#             "is_closed": false,
#             "url": "https://www.yelp.com/biz/la-grande-boucherie-new-york-2?adjust_creative=GEYso0mEPzq3DnGstGe97g&utm_campaign=yelp_api_v3&utm_medium=api_v3_business_search&utm_source=GEYso0mEPzq3DnGstGe97g",
#             "review_count": 2570,
#             "categories": [
#                 {"alias": "french", "title": "French"},
#                 {"alias": "steak", "title": "Steakhouses"},
#                 {"alias": "cocktailbars", "title": "Cocktail Bars"},
#             ],
#             "rating": 4.5,
#             "coordinates": {"latitude": 40.7626274, "longitude": -73.98084109999999},
#             "transactions": ["delivery", "pickup"],
#             "price": "$$$",
#             "location": {
#                 "address1": "145 W 53rd St",
#                 "address2": "",
#                 "address3": null,
#                 "city": "New York",
#                 "zip_code": "10019",
#                 "country": "US",
#                 "state": "NY",
#                 "display_address": ["145 W 53rd St", "New York, NY 10019"],
#             },
#             "phone": "+12125107714",
#             "display_phone": "(212) 510-7714",
#             "distance": 6447.196690217016,
#         },
#         {
#             "id": "ypqK8DWM8Bcs43YveSJnNw",
#             "alias": "manhatta-new-york",
#             "name": "Manhatta",
#             "image_url": "https://s3-media3.fl.yelpcdn.com/bphoto/uHQHaX-Q6_Z0ptEGNFenIw/o.jpg",
#             "is_closed": false,
#             "url": "https://www.yelp.com/biz/manhatta-new-york?adjust_creative=GEYso0mEPzq3DnGstGe97g&utm_campaign=yelp_api_v3&utm_medium=api_v3_business_search&utm_source=GEYso0mEPzq3DnGstGe97g",
#             "review_count": 672,
#             "categories": [{"alias": "newamerican", "title": "New American"}],
#             "rating": 4.5,
#             "coordinates": {
#                 "latitude": 40.70800627689857,
#                 "longitude": -74.00888226517013,
#             },
#             "transactions": [],
#             "price": "$$$$",
#             "location": {
#                 "address1": "28 Liberty St",
#                 "address2": "Fl 60",
#                 "address3": null,
#                 "city": "New York",
#                 "zip_code": "10005",
#                 "country": "US",
#                 "state": "NY",
#                 "display_address": ["28 Liberty St", "Fl 60", "New York, NY 10005"],
#             },
#             "phone": "+12122305788",
#             "display_phone": "(212) 230-5788",
#             "distance": 1262.2789968123395,
#         },
#     ],
#     "total": 15000,
#     "region": {
#         "center": {"longitude": -73.99429321289062, "latitude": 40.70544486444615}
#     },
# }
