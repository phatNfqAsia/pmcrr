import {
    createStore,
    applyMiddleware,
    compose,
  } from 'redux'
import { routerMiddleware } from 'react-router-redux'
import RootReducer from './app-redux'

export const configureStore = (history) => {
    const middlewares = [
        routerMiddleware(history),
      ]
     


    const store = createStore(
        RootReducer,
        {},
        applyMiddleware(...middlewares),
    )
    return store;
}
