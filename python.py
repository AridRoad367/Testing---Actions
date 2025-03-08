import requests

# Hardcoded API key - a typical issue
API_KEY = "12345-ABCDE-SECRET-KEY"

def fetch_data():
    url = f"https://example.com/data?api_key={API_KEY}"
    response = requests.get(url)
    if response.status_code == 200:
        return response.json()
    else:
        raise Exception("Failed to fetch data")

data = fetch_data()
print(data)
