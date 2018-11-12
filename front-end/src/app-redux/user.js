import { fromJS } from 'immutable'

const initialState = fromJS({
    name: '',
})

export default function user(state = initialState, action) {
    switch (action.type) {
        case 'SIGNED_IN_SUCESS': {
            const { name } = action.payload;
            return {...state, name};
        }
        default: {
            return state;
        }
    }
}