import requests
import config
import json

def store_json(unit_test, string):
    with open(string, 'w') as outfile:
        json.dump(unit_test, outfile)
def init_query():
        base_uri = "https://api.edamam.com/"
        search_query = "search?q="
        response = input("what'cha want m8?: ").replace(' ', '%20')
        url = base_uri + search_query + response + "&to=1" +"&app_id=" + config.APP_ID + "&app_key=" + config.RECIPE_SEARCH_APP_KEY
        request = requests.get(url)
        print(str(request.status_code) + "\n")
        print(url)
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
                print("test", recipe )
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
init_query()
dic = retrieve_json('raw_query.json')
parsed_dic = parse_dic(dic)
store_json(parsed_dic, 'parsed_dic.json')

