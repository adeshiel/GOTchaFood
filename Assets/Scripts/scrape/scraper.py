import requests
import config
import json

def ingredient_init():
        with open('ingredients.json', 'r') as ingred:
                ingredi = json.load(ingred)
        return ingredi.keys()

def store_json(unit_test, string):
    with open(string, 'w') as outfile:
        json.dump(unit_test, outfile)
def usr_input_query(ingredient):
        base_uri = "https://api.edamam.com/"
        search_query = "search?q="
        url = base_uri + search_query + ingredient + "&to=5" +"&app_id=" + config.APP_ID + "&app_key=" + config.RECIPE_SEARCH_APP_KEY
        request = requests.get(url)
        ret = request.json()
        store_json(ret, 'raw_query.json')
def retrieve_json(string):
        dic = []
        # 'unit-test.json'
        with open(string, 'r') as f:
                dic = json.load(f)
        return dic
def parse_dic(dic):
        diks = []
        all_dic = {dic['q']:[]}
        hits = dic['hits']
        for x in hits:
                json_dic = {}
                recipe = x['recipe']
                print("test", dic['q'] )
                json_dic = { "name": recipe['label'], "img": recipe['image'], "ing": recipe['ingredientLines'], 'url': recipe['url']}
                all_dic[dic['q']].append(json_dic)
        try:
                superset = retrieve_json('parsed_dic.json')
                if dic['q'] not in superset:
                        superset[dic['q']] = all_dic[dic['q']]
                else:
                        superset[dic['q']] = superset[dic['q']].append(all_dic[dic['q']])
                return superset
        except:
                return all_dic
def main():
        # usr_input_query()
        ingrid = ingredient_init()
        for x in ingrid:
                usr_input_query(x)
                dic = retrieve_json('raw_query.json')
                parsed_dic = parse_dic(dic)
                store_json(parsed_dic, 'parsed_dic.json')
main()