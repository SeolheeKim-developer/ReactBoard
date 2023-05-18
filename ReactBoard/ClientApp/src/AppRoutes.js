import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { Counter } from "./components/Counter";
import { EntryCreate } from './components/Entries/EntryCreate';
import { EntryDelete } from './components/Entries/EntryDelete';
import { EntryDetails } from './components/Entries/EntryDetails';
import { EntryEdit } from './components/Entries/EntryEdit';
import { EntryIndex } from './components/Entries/EntryIndex';
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/Entries',
    element: <EntryIndex />
    },
    {
        path: '/Entries/Create',
        element: <EntryCreate />
    },
    {
        path: '/Entries/Details/:id',
        element: <EntryDetails />
    },
    {
        path: '/Entries/Edit/:id',
        element: <EntryEdit />
    },
    {
        path: '/Entries/Delete/:id',
        element: <EntryDelete />
    },
  {
    path: '/fetch-data',
    requireAuth: true,
    element: <FetchData />
  },
  ...ApiAuthorzationRoutes
];

export default AppRoutes;
