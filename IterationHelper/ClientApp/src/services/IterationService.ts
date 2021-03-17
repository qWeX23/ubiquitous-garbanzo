import axios from 'axios';

export default class IterationService {
    
    public static getIterationNumber(): Promise<number> {
        console.log('calling api...')
        return axios.get('api/Iteration/getIterationNumber')
        .then((response) => {
            return response.data;
        })
        .catch((error) => {
            console.log(error);
        });
        
    }
}