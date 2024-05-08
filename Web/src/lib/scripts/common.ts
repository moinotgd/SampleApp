const BaseUrl = import.meta.env.VITE_API_URL;

export async function GET(url: string) {
    let options = {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        }
    };
    
    const response = await fetch(`${BaseUrl}/${url}`, options);
    return response.json();
} 