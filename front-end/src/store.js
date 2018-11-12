import createHistory from 'history/createBrowserHistory'
import { configureStore } from './store-setup'

export const history = createHistory();
export const store = configureStore(history);
