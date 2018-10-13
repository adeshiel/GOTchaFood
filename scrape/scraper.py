import requests
import config
import json

def store_json(unit_test, string):
    with open(string, 'w') as outfile:
        json.dump(unit_test, outfile)

# base_uri = "https://api.edamam.com/"
# search_query = "search?q="
# response = input("what'cha want m8?: ").split()[0]
# url = base_uri + search_query + response + "&to=3" +"&app_id=" + config.APP_ID + "&app_key=" + config.RECIPE_SEARCH_APP_KEY
# request = requests.get(url)
# print(str(request.status_code) + "\n")
# print(url)
# ret = request.json()
# store_json(ret, 'unit_test.json')
dic = []
def retrieve_json():
        global dic
        with open('unit-test.json', 'r') as f:
                dic = json.load(f)
retrieve_json()
def parse_dic(dic):
        json_dic = {}
        hits = dic['hits']
        # we want url, image, ingredientlines, label
        for x in hits:
                recipe = x['recipe']
                json_dic[recipe['label']] = [recipe['image'], recipe['ingredientLines'], recipe['url']]
        return json_dic
parsed_dic = parse_dic(dic)
store_json(parsed_dic, 'parsed_dic')

